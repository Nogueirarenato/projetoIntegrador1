import React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css"



class FazerPedido extends Component {

    
    constructor() {
        
        super();
        this.state = {
          
        }
    }

    
    componentDidMount() {
        document.title = "Pagina do Administrador - Desperdicio Zero";
        this.setState({ erro: "" });
        
    }


 


render(){
    return (
        <div>
            <Header></Header>
            <div  className= "bodyReact">
            <h1>Fazer Pedido</h1>
            

            


            <Link to="/">retornar a página inicial</Link>
            </div>
            <Footer></Footer>
        </div>
    );
}}

export default FazerPedido;