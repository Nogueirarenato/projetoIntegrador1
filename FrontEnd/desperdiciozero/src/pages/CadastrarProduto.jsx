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
            nome:"",
            dataDeValidade:"",
            prazo:"",
            valorCompra:"",
            valorVenda:"",
            desconto: "",
            idEstoque:"",
            quantidade: "",
            descricao:""
            
        }
    }

    
    componentDidMount() {
        document.title = "Cadastrar Produto - Desperdicio Zero";
        this.setState({ erro: "" });
        
    }


   


render(){
    return (
        <div>
            <Header></Header>
            <div  className= "bodyReact">
            <h1>Cadastrar Produto</h1>
            
            <form onSubmit={null}>

            <div>
                <div>
                    Nome do Produto
                </div>
            <input type="text" placeholder="Nome do Produto" />
            
            </div>

            <div>
             <div>
                 <p>Data de Validade</p>
            </div>   
            <input type="date" />

            <div>
                Anunciar faltando quantos dias para o vencimento?
            </div>
            <div>
                <input type="text" placeholder="Digite o numero de dias..." />
            </div>
            


            </div>
            </form>
            
            


            <Link to="/">retornar a página inicial</Link>
            </div>
            <Footer></Footer>
        </div>
    );
}}

export default CadastrarProduto;