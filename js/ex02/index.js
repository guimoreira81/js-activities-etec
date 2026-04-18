/*
Data: 13/03/2026
Autor: Igor Daniel e Igor Matheus
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
		if (input.toLowerCase().search("c") != -1){
			type = "c";
		}else if (input.toLowerCase().search("f") != -1){
			type = "f";
		}else if (type==null && number==null){
			console.log("Não entendi.");
		}
	}
}

let input = verifyInput("Digite um número em Fahrenheit ou Celsius: ");
