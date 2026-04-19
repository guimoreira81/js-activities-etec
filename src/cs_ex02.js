/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber o peso;
Receber a altura;
Calcular o IMC;
Mostrar a classificação de saúde.
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

console.log("--- Calculadora de IMC ---");
const weight = verifyInput("Digite o seu peso (kg): ");
const height = verifyInput("Digite a sua altura (cm): ")/100;

const IMC = weight/(height*height);
let healthClassification = "N/A";


if (IMC<18.5) {
    healthClassification = "Peso Baixo";
}else if (IMC<25) {
    healthClassification = "Peso Normal";
}else if (IMC<30) {
    healthClassification = "Sobrepeso";
}else if (IMC<35) {
    healthClassification = "Obesidade Grau I";
}else if (IMC<40) {
    healthClassification = "Obesidade Grau II";
}else if (IMC>=40) {
    healthClassification = "Obesidade Grau III";
}

console.log(`O seu IMC é ${Math.floor(IMC*100)/100} e sua classificação de saúde é ${healthClassification}`);