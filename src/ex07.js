/*
Data: 19/04/2026
Autor: Guilherme
Objetivo: Ler 8 números inteiros e separá-los em dois vetores: um com números positivos e outro com negativos

Exercício 7 - Separar Positivos e Negativos
Leia 8 números inteiros e separe em dois vetores:

Um vetor com números positivos
Um vetor com números negativos
*/

const readline = require("readline-sync");

function verifyInput(){
    while (true){
        const input = readline.question();

        let number = Number(input);
        if (Number.isNaN(number) || Math.floor(number)==number){
            return number;
        }

        console.log("Não entendi, tente novamente.");
    }
}

console.log("Digite 8 números inteiros, sendo eles positivos ou negativos:");

let positives = [];
let negatives = [];

for (let i = 0; i<8; i++){
    let number = verifyInput();
    if (number>0){
        positives.push(number);
    }else{
        negatives.push(number);
    }
}

console.log(`Positivos: {${positives}}`);
console.log(`Negativos: {${negatives}}`);