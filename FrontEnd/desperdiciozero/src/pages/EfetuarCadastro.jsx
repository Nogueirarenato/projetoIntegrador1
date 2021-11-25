import React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css";
import Url from '../util/apiURL';




class EfetuarCadastro extends Component {


    constructor() {

        super();
        this.state = {
            idTipo: 2,
            email: "",
            senha: "",
            senha01: "",
            endereco: "",
            documento: "",
            telefone: "",
            erro: "",
            value: ""
        }

        this.atualizaIdTipo = this.atualizaIdTipo.bind(this);
        this.atualizaEmail = this.atualizaEmail.bind(this);
        this.atualizaSenha = this.atualizaSenha.bind(this);
        this.atualizaSenha01 = this.atualizaSenha01.bind(this);
        this.atualizaEndereco = this.atualizaEndereco.bind(this)
        this.atualizaDocumento = this.atualizaDocumento.bind(this)
        this.atualizaTelefone = this.atualizaTelefone.bind(this)

    }


    componentDidMount() {
        document.title = "Efetuar Cadastro - Desperdício Zero";
        this.setState({ erro: "" });


    }
    atualizaIdTipo(event) {
        this.setState({ idTipo: event.target.value })
        console.log(this.state.idTipo)
    }

    atualizaEmail(event) {
        console.log(this.state.idTipo)
        this.setState({ email: event.target.value })
        console.log(this.state.email)
    }
    atualizaSenha(event) {
        this.setState({ senha: event.target.value })
        console.log(this.state.senha)
    }
    atualizaSenha01(event) {
        this.setState({ senha01: event.target.value })
        console.log(this.state.senha01)
    }
    atualizaEndereco(event) {
        this.setState({ endereco: event.target.value })
        console.log(this.state.endereco)
    }
    atualizaDocumento(event) {
        this.setState({ documento: event.target.value })
        console.log(this.state.documento)
    }
    atualizaTelefone(event) {
        this.setState({ telefone: event.target.value })
        console.log(this.state.telefone)
    }

    cadastrarUsuario(event) {

        event.preventDefault();
        if (this.state.idTipo === '2') this.setState({ idTipo: 2 })
        if (this.state.idTipo === '3') this.setState({ idTipo: 3 })

        let user = {
            idTipo: parseInt(this.state.idTipo),
            email: this.state.email,
            senha: this.state.senha,
            endereco: this.state.endereco,
            documento: this.state.documento,
            telefone: this.state.telefone
        }

        console.log(JSON.stringify(user))

        fetch(Url + "usuarios", {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(user),
        }
        ).then(alert(this.state.email + " Cadastro Efetuado com sucesso, faça o login para acessar o sistema"))
            .then(window.location.assign("/Login"))

    }



    render() {
        return (
            <div>
                <Header></Header>
                <div className="bodyReact">

                    <div className="login3">
                        <div className="login4">
                            <h2>Efetuar Cadastro</h2>

                            <form>
                                <div>
                                    
                                    <input type="text" placeholder="email" onChange={this.atualizaEmail.bind(this)} />
                                    
                                </div>
                                <div>
                                    <input type="password" placeholder="Digite uma senha" onChange={this.atualizaSenha.bind(this)} />
                                    

                                </div>
                                <div>
                                    <input type="password" placeholder="Repita a senha escolhida" onChange={this.atualizaSenha01.bind(this)} />
                                </div>
                                <div>
                                    <input type="text" placeholder="Digite seu endereço" onChange={this.atualizaEndereco.bind(this)} />
                                </div>
                                <div>
                                    <input type="text" placeholder="Digite seu CPF ou CNPJ" onChange={this.atualizaDocumento.bind(this)} />
                                </div>
                                <div>
                                    <input type="text" placeholder="Digite seu Telefone" onChange={this.atualizaTelefone.bind(this)} />
                                </div>
                                <div>

                                </div>
                                <form>
                                    <select onChange={this.atualizaIdTipo}>
                                        <option value='2' >Vendedor</option>
                                        <option value='3' >Consumidor</option>

                                        {this.state.value}
                                    </select>
                                </form>

                            </form>
                            <form onSubmit>
                                <input id='1_menu' type="submit" value="Cadastrar" onClick={this.cadastrarUsuario.bind(this)} />
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

export default EfetuarCadastro;