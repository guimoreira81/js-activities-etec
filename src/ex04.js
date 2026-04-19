/*
Data: 18/04/2026
Autor: Guilherme
Objetivo:

Exercício 4 - Triângulo Numérico
Leia um número n e imprima n linhas no seguinte formato (exemplo para n = 6):

1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
1 2 3 4 5 6
*/

const readline = require('readline-sync');

function verifyInput(message){
    while (true) {
        const input = readline.question(message);
        
        const number = Number(input);
        if (!Number.isNaN(number) && number>0 && Number.isInteger(number)){
            return number;
        }

        console.log("Não entendi, tente novamente.");
    }
}

console.log("--- Triângulo Numérico ---");
const n = verifyInput("Digite um número inteiro positivo: ");

for (let i = 1; i <= n; i++) {
    let line = ""
    for (let j = 1; j <= i; j++){
        line += ` ${j}`;
    }
    console.log(line);
}