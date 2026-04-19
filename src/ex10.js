/*
Data: 19/04/2026
Autor: Guilherme
Objetivo: Ler um ano e informar se ele é bissexto com base nas regras de múltiplos de 4, 100 e 400

Exercício 10 - Ano Bissexto
Leia um ano e informe se ele é bissexto.

Um ano é bissexto se:

É múltiplo de 400
ou
É múltiplo de 4 e não é múltiplo de 100
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        const input = readline.question(message);

        const number = Number(input);
        if (!Number.isNaN(number)){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

console.log("--- Verificar se Ano é Bissexto ---");

const year = verifyInput("Digite um ano: ");

if (year%400==0 || year%4==0 && year%100!=0){
    console.log("Esse ano é bissexto!");
}else{
    console.log("Esse ano não é bissexto!");
}