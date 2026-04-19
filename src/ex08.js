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
        console.log(message);
        const input = readline.question();

        let number = Number(input);
        if (!Number.isNaN(number) && Math.floor(number)==number){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

function soma(n){
    let sum = 0;
    if (n>0){
        for (let i = 0; i<n+1; i++){
            sum+=i;
        }
    }else{
        for (let i = 0; i>n-1; i--){
            sum+=i;
        }
    }
    return sum;
}

const number = verifyInput("Digite um número inteiro: ");
let result = soma(number);
console.log(`A soma de todos os números, de 0 até ${number} é ${result}.`);