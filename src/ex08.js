/*
Data: 19/04/2026
Autor: Guilherme
Objetivo: Criar uma função soma(n) que receba um número inteiro e retorne o somatório de 0 até esse número

Exercício 8 - Soma de 0 até N com Função
Crie uma função soma(n) que receba um número inteiro e retorne a soma de 0 até esse número.
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        const input = readline.question(message);

        const number = Number(input);
        if (!Number.isNaN(number) && Number.isInteger(number)){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

function soma(n){
    let sum = 0;
    if (n>0){
        for (let i = 0; i<=n; i++){
            sum+=i;
        }
    }else{
        for (let i = 0; i>=n; i--){
            sum+=i;
        }
    }
    return sum;
}

console.log("--- Calcular a soma de todos os números inteiros de N até 0 ---");

const number = verifyInput("Digite um número inteiro: ");
let result = soma(number);
console.log(`A soma de todos os números inteiros, de 0 até ${number} é ${result}.`);