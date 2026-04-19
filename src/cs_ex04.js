/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber 4 números do usuário;
Determinar o Maior e o Menor;
Mostrar os Resultados.
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

console.log("--- Maior e Menor Número ---");

let numbers = [];
for (let i = 0; i<4; i++){
    numbers.push(verifyInput(`${i+1}° Número: `));
}

numbers = numbers.sort((a, b) => a-b);

const smallestNumber = numbers[0];
const greatestNumber = numbers[3];

console.log(`O menor número é ${smallestNumber};\nO maior número é ${greatestNumber}.`);