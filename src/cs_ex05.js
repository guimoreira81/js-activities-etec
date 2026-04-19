/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber 3 números;
Ordernar em Ordem Crescente;
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

console.log("--- Ordernar Números ---");

let numbers = [];
for (let i = 0; i<3; i++){
    numbers.push(verifyInput(`${i+1}° número: `));
}
numbers = numbers.sort((a, b) => a-b);

console.log(`Ordem Crescente: ${numbers}.`);