/*<!--
Data: 14/04/2026
Autor: Guilherme
Objetivo:

Exercício 1 - Intervalo entre 100 e 200
Faça um programa que receba um número e diga se este número está no intervalo entre 100 e 200.
*/

// Execute esse programa no terminal, usando o comando "node ex01.js"
const readline = require("readline-sync");

// Verifica se o Input é um número, se não, perguntar de novo
function verifyInput(message){
	while (true){
		const input = readline.question(message);

		const number = Number(input);
		if (!Number.isNaN(number)){
			return number;
		}else{
			console.log("Não entendi, tente de novo.");
		}
	}
}

console.log("--- Verificar se Número está entre 100 e 200 ---");
const number = verifyInput("Digite em Número para verificar se ele está entre 100 e 200: ");

if (number >= 100 && number <= 200){
	console.log(`O número ${number} está entre 100 e 200!`);
}else{
	console.log(`O número ${number} não está entre 100 e 200!`);
}
