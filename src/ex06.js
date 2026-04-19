/*
Data: 18/04/2026
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

let result = 0;
let previous = [null, null];
for (let i = 0; i<n; i++){
    if (previous!=[null, null]){
        result += previous[0]+previous[1];
    }else{
        result += 1;
    }
    previous = [previous[1], result];
}

console.log(`Os ${n}° número da sequência de Fibonacci é ${result}`)