/*<!--
Data: 14/04/2026
Autor: Guilherme
Objetivo:

Exercício 1 - Intervalo entre 100 e 200
Faça um programa que receba um número e diga se este número está no intervalo entre 100 e 200.
*/

// Execute esse programa no terminal, usando o comando "node ex01.js"
const readline = require("readline-sync");

// Verifica se o Input é um número, se não, pergunta de novo
function verifyInput(message){
	while (true){
		console.log(message);
		let input = readline.question();
		if (!isNaN(input)){
			return Number(input);
		}else{
			console.log("Não entendi, tente de novo.");
		}
	}
}

let number = verifyInput("Digite em Número para verificar se ele está entre 100 e 200: ");

if (number >= 100 && number <= 200){
	console.log(`O número ${number} está entre 100 e 200!`);
}else{
	console.log(`O número ${number} não está entre 100 e 200!`);
}
