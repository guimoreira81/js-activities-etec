/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber o número de lados de um polígono e seu tamanho;
Determinar que polígono é;
Mostrar o resultado;
*/

const readline = require("readline-sync");

function verifyInput(message){
    while (true){
        const input = readline.question(message);

        const number = Number(input);
        if (!Number.isNaN(number) && number > 0){
            return number;
        }

        console.log("Não entendi, tente de novo.");
    }
}

console.log("--- Polígonos Regulares ---");

const numberOfSides = verifyInput("Número de Lados: ");
const length = verifyInput("Tamanho de cada Lado (cm): ");

const classes = [
    "Não Existe",
    "Não Existe",
    "Triângulo",
    "Quadrilátero",
    "Pentágono",
    "Hexágono",
    "Heptágono",
    "Octógono",
    "Eneágono",
    "Decágono",
    "Undecágono",
    "Dodecágono",
];

let classification = classes[numberOfSides-1];
let area = (numberOfSides*(length*length))/(4*Math.tan(Math.PI/numberOfSides));
area = Math.floor(area*100)/100;

if (classification){
    console.log(`Esse é um ${classification}, ele tem a área de ${area}cm²`);
}else if (numberOfSides >= 3){
    console.log(`Esse é um ${numberOfSides}-látero, ele tem a área de ${area}cm²`);
}else{
    console.log("Esse polígono não existe.");
}