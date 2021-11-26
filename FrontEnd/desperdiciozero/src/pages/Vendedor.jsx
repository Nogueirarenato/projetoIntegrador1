import React from 'react';
import { Component } from 'react';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css"



class Vendedor extends Component {


    constructor() {

        super();
        this.state = {

        }
    }


    componentDidMount() {
        document.title = "Pagina do Vendedor - Desperdicio Zero";
        this.setState({ erro: "" });

    }





    render() {
        return (
            <div>
                <Header></Header>
                <div className="bodyReact">
                <h2 style={{textAlign: "center", marginTop: "0.3%"}}>Painel do Vendedor</h2>
                    <div className="painelvendedor">
                        <div></div>
                        
                        <div></div>
                        <a className="linkVendedor" href="/CadastrarProduto">Cadastrar um produto</a>
                        <a className="linkVendedor" href="/CadastrarProduto">Apagar um produto</a>
                        <a className="linkVendedor" href="/CadastrarProduto">Verificar Estoque</a>
                        
                        <a className="linkVendedor" href="/">Retornar à página inicial</a>
                        <a className="linkVendedor" href="/">Fazer Logoff</a>
                    </div>
                </div>
                <Footer></Footer>
            </div>
        );
    }
}

export default Vendedor;