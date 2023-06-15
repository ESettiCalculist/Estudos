import {Cliente} from "./Cliente.js"
import {ContaCorrente} from "./Conta/ContaCorrente.js"
import { ContaPoupanca } from "./Conta/ContaPoupanca.js";
import { ContaSalario } from "./Conta/ContaSalario.js";
import { Diretor } from "./Funcionario/Diretor.js";
import { Gerente } from "./Funcionario/Gerente.js";
import { SistemaAutenticacao } from "./SistemaAutenticacao.js";

const cliente1 = new Cliente("Ricardo", 11122233309);
const cliente2 = new Cliente("Alice", 88822233309);

const contaCorrenteRicardo = new ContaCorrente(cliente1, 1001);
contaCorrenteRicardo.depositar(500);
contaCorrenteRicardo.sacar(100);

const contaPoupanca = new ContaPoupanca(200, cliente1, 1001)

const contaSalario = new ContaSalario(cliente1)
contaSalario.depositar(200);
contaSalario.sacar(100);

const gerente = new Gerente("rodrigo", 1000, 12345678900)
gerente.cadastrarSenha("1233")
const diretor = new Diretor("ricardo", 5000, 12345898374)
diretor.cadastrarSenha("1234567")

const cliente = new Cliente("lais", 38109684354, "456")
const diretorEstaLogado = SistemaAutenticacao.login(diretor, "1234567")
const gerenteEstaLogado = SistemaAutenticacao.login(gerente, "1233")
console.log(gerenteEstaLogado)
const clienteEstaLogado = SistemaAutenticacao.login(cliente, "456")


console.log(clienteEstaLogado)
