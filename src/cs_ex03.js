/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber a Idade;
Checar a faixa de Idade que se cai;
Mostrar a classificação.
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        const input = readline.question(message);

        const number = Number(input);
        if (!Number.isNaN(number) && number>0 && Number.isInteger(number)){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

console.log("--- Classificação de Nadadores ---");
const age = verifyInput("Digite a sua idade: ");

let classification = "";


if (age<5) {
    classification = "Não pode ser classificado";
}else if (age<7) {
    classification = "Infantil A";
}else if (age<10) {
    classification = "Infantil B";
}else if (age<13) {
    classification = "Juvenil A";
}else if (age<17) {
    classification = "Juvenil B";
}else if (age>18) {
    classification = "Sênior";
}

console.log(`A sua classificação é ${classification}.`);