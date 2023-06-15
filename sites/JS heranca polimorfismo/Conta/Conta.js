//classe abstrata, funciona para ser herdada somente
export class Conta{
    constructor(saldoInicial, cliente, agencia) {
        this._saldo = saldoInicial
        this._cliente = cliente
        this._agencia = agencia

        // lançamento de erro ao tentar instanciar a classe conta diretamente no index
        if(this.constructor == Conta){
            throw new Error("Você nao deve instanciar um objeto do tipo conta, pois ela é uma classe abstrata")
        }
    }

    set cliente(novoValor){
        if(novoValor instanceof Cliente){
            this._cliente = novoValor;
        }
    }

    get cliente(){
        return this._cliente;
    }

    get saldo(){
        return this._saldo;
    }

    sacar(valor) {
       throw new Error("Metodo sacar da conta é abstrato")
    }

    _sacar(valor, taxa){
        const valorSacado = taxa * valor
        if(this._saldo >= valorSacado){
            this._saldo -= valor;
            return valor;
        }

        return 0
    }

    depositar(valor){
        if(valor <= 0)
        {
            return;
        } 
        this._saldo += valor;           
    }

    tranferir(valor, conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
        
    }
}