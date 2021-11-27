import React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css"
import 'bootstrap/dist/css/bootstrap.min.css';
import Table from 'react-bootstrap/Table'
import Url from '../util/apiURL';
import { ThemeConsumer } from 'react-bootstrap/esm/ThemeProvider';

let vetor = [];
let indice = -1

class FazerPedido extends Component {


    constructor() {

        super();
        this.state = {
            dados: "",
            listProducts: [],


        }

    }


    componentDidMount() {
        document.title = "Pagina do Consumidor - Desperdicio Zero";
        this.setState({ erro: "" });
        this.carregarPedidos();

    }

    carregarPedidos() {
        fetch(Url + "produtos", {
            method: 'GET',
            headers: {
                "Content-Type": "application/json",

            }
        }
        ).then(response => response.json())
            .then(data => {
                console.log(data)
                this.setState({ dados: data })
                console.log(this.state.dados)

            })
            .catch(erro => console.log(erro))
            .then(data => {

                this.setState({ listProducts: this.state.dados })
                    .then(console.log(this.state.listProducts))


            })

            .catch(erro => console.log(erro))


    }



    render() {
        return (
            <div>
                <Header></Header>
                <div className="bodyReact">
                    <h2>Ofertas Disponíveis</h2>


                    <div style={{ margin: "1%" }}>

                        <Table striped bordered hover size="sm">
                            <thead>
                                <tr>
                                    <th>id</th>
                                    <th>Produto</th>
                                    <th>Data de Validade</th>
                                    <th>Valor com desconto</th>
                                    <th>Quantidade Disponível</th>
                                    <th>Observação</th>
                                    <th>Adicionar</th>
                                    <th>_</th>
                                   
                                </tr>
                            </thead>
                            <tbody>
                                {
                                    this.state.listProducts.map(element => {
                                        vetor.push(element.idproduto)
                                        console.log(element)


                                        return (

                                            <tr key={element.idproduto}>
                                                <td className="tac">{element.idproduto}</td>
                                                <td>{element.nome}</td>
                                                <td className="tac">{(element.dataDeValidade).charAt(8)+(element.dataDeValidade).charAt(9)+"/"+(element.dataDeValidade).charAt(5)+(element.dataDeValidade).charAt(6)+"/"+(element.dataDeValidade).charAt(0)+(element.dataDeValidade).charAt(1)+(element.dataDeValidade).charAt(2)+(element.dataDeValidade).charAt(3)}</td>
                                                <td className="tac">R$ {(element.valorVenda * ((100 - element.desconto) / 100)).toFixed(2)}</td>
                                                <td className="tac">{element.quantidade}</td>
                                                <td >{element.descricao}</td>
                                        
                                                <td><input type="number" id="quantity" name="quantity" min="0" max={element.quantidade} placeholder="0"/></td>
                                                <td><input type="button" value="adicionar" /></td>

                                            </tr>)
                                    })
                                }
                            </tbody>
                        </Table>
                    </div>

                    <Link to="/" style={{marginLeft: '80vw'}}>Fazer Logoff</Link>
                </div>
                <Footer></Footer>
            </div>
        );
    }
}

export default FazerPedido;