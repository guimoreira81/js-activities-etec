/*
Data: 18/04/2026
Autor: Guilherme
Objetivo:

Exercício 3 - Calculadora Aritmética
Faça um programa que leia dois números e um operador ("+", "-", "*" ou "/").
O programa deve mostrar o resultado da operação.
*/

const readline = require("readline-sync");

function verifyInput(message, type){
    while (true){
        console.log(message);
        const input = readline.question();

        if (!Number.isNaN(Number(input)) && type=="number"){
            return Number(input);
        }
        if ((input == "+" || input == "-" || input == "*" || input == "/") && type=="operator"){
            return input;
        }
        console.log("Não entendi, tente de novo.");
    }
}

let number1 = verifyInput("Digite o 1° Número: ", "number");
let operator = verifyInput("Digite o Operador (+, -, * ou /): ", "operator");
let number2 = verifyInput("Digite o 2° Número: ", "number");

let result = null;
switch (operator){
    case "+":
        result = number1+number2;
        break;
    case "-":
        result = number1-number2;
        break;
    case "*":
        result = number1*number2;
        break;
    case "/":
        if (number2 != 0){
            result = number1/number2;
        }else{
            console.log("Não é possível dividir por zero.");
            return;
        }
        break;
}

if (result != null){
    console.log(`O resultado é: ${number1}${operator}${number2} = ${result}`);
}