/*
Data: 18/04/2026
Autor: Guilherme
Objetivo:

Faça um programa que leia um caractere "F" ou "C", indicando se o valor informado está em Fahrenheit ou Celsius.
Depois, o programa deve converter para a outra unidade.
Fórmula: C = 5/9 × (F − 32)
*/

const readline = require("readline-sync");

function verifyInput(message){
	while (true){
		console.log(message);
		let input = readline.question();

		let type = null;
		let number = null;
		let canReturn = true;

		// Conseguir Numero
		let firstNumberMatch = input.match(/-?\d+/g);
		if (firstNumberMatch != null && Number(firstNumberMatch[0]) != NaN){
			number = Number(firstNumberMatch[0]);
		}
		
		//Conseguir Tipo (C ou F)
		if (input.toLowerCase().search("c") != -1){
			type = "c";
		}else if (input.toLowerCase().search("f") != -1){
			type = "f";
		}else if (type==null || number==null){
			console.log("Não entendi.");
			canReturn = false;
		}
		if (canReturn){
			return [type, number]
		}
	}
}

let data = verifyInput("Digite um número em Fahrenheit ou Celsius (Exemplos: 10F, 10C): ");
if (data[0] == "f"){ 
	console.log(`${data[1]}°F é igual a ${5/9*(data[1]-32)}°C!`);
}else if (data[0] == "c"){
	console.log(`${data[1]}°C é igual a ${5/9*data[1]+32}°F!`);
}