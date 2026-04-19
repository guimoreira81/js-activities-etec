/*
Data: 18/04/2026
Autor: Guilherme
Objetivo:

Exercício 5 - Somatório de Fatoriais
Leia 5 números inteiros e mostre a soma dos fatoriais desses números.
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        console.log(message);
        const input = readline.question();

        const number = Number(input);
        if (!Number.isNaN(number)){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

let numbers = [];

for (let i = 0; i < 5; i++){
    numbers[i] = verifyInput(`Digite o ${i+1}° número: `);
}

let factorials = []

for (const [index, number] of numbers.entries()){
    let factorial = number;
    for (let i = number-1; i>1; i--){
        factorial *= i;
    }
    if (number == 0){
        factorial = 1;
    }
    factorials[index] = factorial;
    console.log(`O fatorial de ${number} é ${factorial}`);
}

let sumOfAllFactorials = 0;
for (sum of factorials){
    sumOfAllFactorials += sum;
}
console.log(`A soma de todos os fatoriais é ${sumOfAllFactorials}`);