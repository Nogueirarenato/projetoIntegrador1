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
    }


    componentDidMount() {
        document.title = "Cadastrar Produto - Desperdicio Zero";
        this.setState({ erro: "" });

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
                                    <input type="text" placeholder="Nome do Produto" />

                                </div>

                                <div>
                                    <div>
                                        Data de Validade
                                    </div>
                                    <input type="date" />

                                    <div>
                                        Anunciar faltando quantos dias para o vencimento?
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o numero de dias..." />
                                    </div>

                                    <div>
                                        Valor de Compra
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o valor de compra do produto" />
                                    </div>

                                    <div>
                                        Valor de Venda
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite o valor de venda do produto" />
                                    </div>

                                    <div>
                                        Porcentagem de Desconto
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Desconto em %" />
                                    </div>

                                    <div>
                                        Quantidade
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite a quantidade" />
                                    </div>

                                    <div>
                                        Alguma observação?
                                    </div>
                                    <div>
                                        <input type="text" placeholder="Digite a observação..." />
                                    </div>




                                </div>
                            </form>


                            <form onSubmit>
                                <input id='1_menu' type="submit" value="Cadastrar" onClick={null} />
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