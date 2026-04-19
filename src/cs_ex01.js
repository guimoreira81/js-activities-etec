/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber o nome do estudante;
Receber 3 notas;
Calcular a média;
Mostrar se o estudante está: Aprovado ou Reprovado.
*/

const readline = require("readline-sync");

function verifyInput(message, type){
    while (true){
        const input = readline.question(message);

        const number = Number(input);
        if (type=="number" && !Number.isNaN(number)){
            return number;
        }else if (type=="string"){
            return input;
        }

        console.log("Não entendi, tente de novo.");
    }
}

console.log("--- Calcular Média de Nota ---");
const name = verifyInput("Digite o seu nome: ", "string");

let sum = 0;

for (let i = 0; i<3; i++){
    sum += verifyInput(`${i+1}° nota: `, "number");
}

const average = sum/3;
const status = average>5 ? "Aprovado" : "Reprovado";

console.log(`${name}, sua média é ${average}, e você está ${status}!`);