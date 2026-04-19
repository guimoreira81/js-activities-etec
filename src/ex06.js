/*
Data: 19/04/2026
Autor: Guilherme
Objetivo: Ler um número n e mostrar os n primeiros termos da sequência de Fibonacci

Exercício 6 - Série de Fibonacci
Leia um número n e mostre os n primeiros termos da sequência de Fibonacci.

Exemplo:
n = 12
Resultado:
0 1 1 2 3 5 8 13 21 34 55 89
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        console.log(message);
        const input = readline.question();

        let number = Number(input);
        if (!Number.isNaN(number) && number >= 0){
            return number;
        }
        console.log("Não entendi, tente de novo.");
    }
}

const n = verifyInput("Digite um número inteiro positivo: ");

let list = [];
let a = 0, b = 1;
for (let i = 0; i<n; i++){
    list.push(a);
    [a, b] = [b, a+b];
}

console.log(`Os ${n} primeiros números da sequência de Fibonacci são: \n${list}`);