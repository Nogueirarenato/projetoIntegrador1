import React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css"
import Url from '../util/apiURL';

var dadosUsuarios;


class CadastrarProduto extends Component {


    constructor() {

        super();
        this.state = {
            nome: "",
            dataDeValidade: "",
            prazo: "",
            valorCompra: "",
            valorVenda: "",
            desconto: "",
            idEstoque: "",
            quantidade: "",
            descricao: ""

        }
        this.atualizaNome = this.atualizaNome.bind(this);
        this.atualizaDataDeValidade = this.atualizaDataDeValidade.bind(this);
        this.atualizaPrazo = this.atualizaPrazo.bind(this);
        this.atualizaValorCompra = this.atualizaValorCompra.bind(this);
        this.atualizaValorVenda = this.atualizaValorVenda.bind(this);
        this.atualizaDesconto = this.atualizaDesconto.bind(this);
        this.atualizaIdEstoque = this.atualizaIdEstoque.bind(this);
        this.atualizaQuantidade = this.atualizaQuantidade.bind(this);
        this.atualizaDescricao = this.atualizaDescricao.bind(this);
    }


    componentDidMount() {
        document.title = "Cadastrar Produto - Desperdicio Zero";
        this.setState({ erro: "" });


    }

    atualizaNome(event) {
        this.setState({ nome: event.target.value })
        console.log(this.state.nome)
    };

    atualizaDataDeValidade(event) {
        this.setState({ dataDeValidade: event.target.value })
        console.log(this.state.dataDeValidade)
    };
    atualizaPrazo(event) {
        this.setState({ prazo: event.target.value })
        console.log(this.state.prazo)
    };
    atualizaValorCompra(event) {
        this.setState({ valorCompra: event.target.value })
        console.log(this.state.valorCompra)
    };
    atualizaValorVenda(event) {
        this.setState({ valorVenda: event.target.value })
        console.log(this.state.valorVenda)
    };
    atualizaDesconto(event) {
        this.setState({ desconto: event.target.value })
        console.log(this.state.desconto)
    };
    atualizaIdEstoque() { };
    atualizaQuantidade(event) {
        this.setState({ quantidade: event.target.value });
        console.log(this.state.quantidade);
    };
    atualizaDescricao(event) {
        this.setState({ descricao: event.target.value })
        console.log(this.state.descricao)
    };

    cadastrarProduto(event) {
        event.preventDefault()
        let dia_ = (this.state.dataDeValidade).charAt(8) + (this.state.dataDeValidade).charAt(9)
        let mes_ = (this.state.dataDeValidade).charAt(5) + (this.state.dataDeValidade).charAt(6)
        let ano_ = (this.state.dataDeValidade).charAt(0) + (this.state.dataDeValidade).charAt(1) + (this.state.dataDeValidade).charAt(2) + (this.state.dataDeValidade).charAt(3)
        console.log(dia_ + "/" + mes_ + "/" + ano_)


        let nome_ = this.state.nome;
        let dataDeValidade_ = ano_ + "-" + mes_ + "-" + dia_ + "T00:00:00";
        let prazo_ = parseInt(this.state.prazo)

        let valorCompra_ = (this.state.valorCompra).replace(",", ".");
        console.log(valorCompra_)
        valorCompra_ = parseFloat(valorCompra_)
        console.log(valorCompra_)
        let valorVenda_ = (this.state.valorVenda).replace(",", ".");
        console.log(valorVenda_)
        valorVenda_ = parseInt(valorVenda_)
        let desconto_ = (this.state.desconto).replace(",", ".");
        console.log(desconto_);
        desconto_ = parseFloat(desconto_)
        let quantidade_ = parseInt(this.state.quantidade)
        let observacao_ = this.state.descricao




        let produto = {
            nome: nome_,
            dataDeValidade: dataDeValidade_,
            prazo: prazo_,
            valorCompra: valorCompra_,
            valorVenda: valorVenda_,
            desconto: desconto_,
            quantidade: quantidade_,
            descricao: observacao_
        }

        //console.log(JSON.stringify(produto))

         fetch(Url + "produtos", {
             method: 'POST',
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(produto),
        }
        ).then(alert(this.state.nome + " Cadastro Efetuado com sucesso"))
        .then(window.location.assign("/Vendedor"))



    }




    render() {
        return (
            <div>
                <Header></Header>
                <div className="bodyReact">


                    <div className="login5">
                        <div className="login6">
                            <h2>Cadastrar Produto</h2>
                            <form onSubmit={null}>

                                <div>
                                    <div>
                                        Nome do Produto
                                    </div>
                                    <input type="text" placeholder="Nome do Produto" onChange={this.atualizaNome.bind(this)} />

                                </div>

                                <div>
                                    <div>
                                        Data de Validade
                                    </div>
                                    <input type="date" onChange={this.atualizaDataDeValidade.bind(this)} />

                                    <div>
                                        Anunciar faltando quantos dias para o vencimento?
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o numero de dias..." onChange={this.atualizaPrazo.bind(this)} />
                                    </div>

                                    <div>
                                        Valor de Compra
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o valor de compra do produto" onChange={this.atualizaValorCompra.bind(this)} />
                                    </div>

                                    <div>
                                        Valor de Venda
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o valor de venda do produto" onChange={this.atualizaValorVenda.bind(this)} />
                                    </div>

                                    <div>
                                        Porcentagem de Desconto
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Desconto em %" onChange={this.atualizaDesconto.bind(this)} />
                                    </div>

                                    <div>
                                        Quantidade
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite a quantidade" onChange={this.atualizaQuantidade.bind(this)} />
                                    </div>

                                    <div>
                                        Alguma observação?
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite a observação..." onChange={this.atualizaDescricao.bind(this)} />
                                    </div>




                                </div>
                            </form>


                            <form onSubmit={this.cadastrarProduto.bind(this)}>
                                <input id='1_menu' type="submit" value="Cadastrar" />
                                <Link to="/">retornar a página inicial</Link>
                            </form>


                        </div>
                    </div>
                </div>
                <Footer></Footer>
            </div>
        );
    }
}

export default CadastrarProduto;