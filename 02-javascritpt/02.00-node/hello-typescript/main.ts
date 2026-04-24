var minhaVar = 'minha variável';

function minhaFunc(x: number, y: number): number {
    return x + y;
}

//ECMAScript 6 ou ES6 (2015)
//site do ECMAScript: https://www.ecma-international.org/publications-and-standards/standards/ecma-262/ ou https://es6-fatures.org
//Definição de constantes | objeto
const PI = 3.14;
//Definição de variáveis
let num1 = 2;
var num2 = 3;
var objeto = { nome: 'João', idade: 30 };
var array = [1, 2, 3];
//Programação funcional
array.map(function (item) {
    return item * 2;
});

//Arrow function
array.map(item => item * 2);

//Template literal
var nome = 'Maria';
var saudacao = `Olá, ${nome}! Bem-vinda ao TypeScript.`;

//Trasnpiler é um programa que converte código de uma linguagem de programação para outra. 
// No caso do TypeScript, o transpiler converte o código TypeScript para JavaScript, 
// permitindo que ele seja executado em ambientes que suportam JavaScript. 
// O processo de transpile é necessário porque o TypeScript inclui recursos adicionais, 
// como tipagem estática, que não são nativamente suportados pelo JavaScript.

//Babel é um transpiler amplamente utilizado para converter código JavaScript moderno (ES6 e além) 
// em uma versão mais antiga do JavaScript (ES5) que é compatível com navegadores mais antigos. 
// Ele permite que os desenvolvedores usem recursos modernos do JavaScript sem se preocupar com a 
// compatibilidade do navegador, garantindo que o código funcione em uma ampla variedade de ambientes. 
// Babel também suporta a conversão de código TypeScript para JavaScript, tornando-o uma ferramenta útil 
// para projetos que utilizam TypeScript.
// https://babeljs.io/


//Tipando variáveis
let minhaString: string = 'Olá, TypeScript!';
let meuNumero: number = 42;
let minhaBoolean: boolean = true;
let meuArray: number[] = [1, 2, 3];
let meuObjeto: { nome: string; idade: number } = { nome: 'João', idade: 30 };

//Modificadores de acesso
class Pessoa {
    private nome: string;
    protected idade: number;
    public cidade: string;

    constructor(nome: string, idade: number, cidade: string) {
        this.nome = nome;
        this.idade = idade;
        this.cidade = cidade;
    }
}

//Interfaces
interface IAnimal {
    nome: string;
    idade: number;
    fazerSom(): void;
}
