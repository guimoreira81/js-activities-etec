/*
Data: 19/04/2026
Autor: Guilherme
Objetivo: Criar uma função que receba uma lista de números reais e retorne a média aritmética

Exercício 9 - Média Aritmética com Função
Crie uma função:

function media($v)

Que receba uma lista de números reais e retorne a média aritmética.
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        const input = readline.question(message);

        const number = Number(input)
        if (!Number.isNaN(number)){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

console.log("--- Cacular a Média de uma Lista de Números ---");

const listNumber = verifyInput("Quantos números a lista deve ter: ");
let sum = 0;

for (let i = 0; i<listNumber; i++){
    sum += verifyInput(`${i+1}° número: `);
}

const average = sum/listNumber;

console.log(`A média entre todos esses números é ${average}`);