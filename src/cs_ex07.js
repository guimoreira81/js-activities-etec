/*
Data: 19/04/2026
Autor: Guilherme

Objetivo:
Receber 3 valores (Tamanho dos Lados);
Checar se eles podem formar um Triângulo;
Se sim, classifique-o em Equilátero, Isosceles ou Escaleno;
Mostrar os Resultados.
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

console.log("--- Classificar Triângulos ---");

const lengthOfSides = [];

for (let i = 0; i<3; i++){
    lengthOfSides.push(verifyInput(`${i+1}° Lado: `));
}

const canFormTriangle = lengthOfSides[0]+lengthOfSides[1] > lengthOfSides[2] && lengthOfSides[0]+lengthOfSides[2] > lengthOfSides[1] && lengthOfSides[1]+lengthOfSides[2] > lengthOfSides[0];

if (canFormTriangle){
    console.log("Pode se formar um Triângulo.");
    let type = "";

    let numberOfEqualSides = 3;
    for (let otherSide of lengthOfSides){
        if (lengthOfSides[0] != otherSide){
            numberOfEqualSides -= 1;
        }
    }
    switch (numberOfEqualSides){
        case 3:
            type = "Equilátero";
            break;
        case 2:
            type = "Isósceles";
            break;
        case 1:
            type = "Escaleno";
            break;
    }
    
    console.log(`É um Triângulo ${type}.`);
}else{
    console.log("Não se pode formar um Triângulo.");
}