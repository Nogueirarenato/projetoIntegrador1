import React from 'react';
import { Component } from 'react';
import { Link } from 'react-router-dom';
import Footer from '../components/Footer';
import Header from '../components/Header';
import "../styles/Styles.css"
import Url from '../util/apiURL';

var dadosUsuarios;


class Login extends Component {

    
    constructor() {
        
        super();
        this.state = {
            dados:"",
            user: "",
            senha: "",
            userLogado: "",
            erro: "",
            passLogado:""
        }
    }

    
    componentDidMount() {
        document.title = "Login - Desperdicio Zero";
        this.setState({ erro: "" });
        this.carregarUsuarios();
    }


    carregarUsuarios(){
        console.log("Efetuando Requisições");
        


        fetch(Url + "usuarios", {
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
            dadosUsuarios= this.state.dados
        })
        .then()
        .then(localStorage.setItem("usuarios", dadosUsuarios))
        .catch(erro => console.log(erro))
        

    }
    
    atualizaEstadoUsuario(event){
        this.setState({userLogado: event.target.value})
       // console.log(this.state.userLogado)
    }

    atualizaEstadoSenha(event){
        this.setState({passLogado: event.target.value})
       // console.log(this.state.passLogado)
    }

    

    verificaLogin(event){

        event.preventDefault();
        this.state.dados.map(a=>{
            if(a.email === this.state.userLogado && a.senha ===this.state.passLogado ){
                localStorage.setItem("idUsuario", a.idusuario )
                localStorage.setItem("idTipo", a.idTipo )
                localStorage.setItem("email", a.email )
                localStorage.setItem("endereco", a.endereco )
                localStorage.setItem("documento", a.documento)
                localStorage.setItem("telefone", a.telefone)
                localStorage.setItem("senha", a.senha)
                console.log(a.idTipo)
                if(a.idTipo===1){
                    window.location.assign("/Administrador");
                }
                if(a.idTipo===2){
                    window.location.assign("/Vendedor")
                }
                if(a.idTipo===3){
                    window.location.assign("FazerPedido")
                }
                
                
            }
            else{this.setState({erro: "Usuário ou senha inválidos"})}
        }
            
        )
    }


render(){
    return (
        <div>
            <Header></Header>
            <div  className= "bodyReact">
            <h1>Login</h1>
            

            <form onSubmit={this.verificaLogin.bind(this)}>
            <div>
            
            <input type="email" name="email" id="email" placeholder= "Entre com seu email" onChange={this.atualizaEstadoUsuario.bind(this)} />
            </div>
            <div>
            <input type="password" name="password" id="password" placeholder= "Entre com sua senha" onChange= {this.atualizaEstadoSenha.bind(this)} />
            </div>
            <div><h3>{this.state.erro}</h3></div>
            <div>
                <button id="botaoEntrar" type="submit" name="entrar">Entrar</button>
            
            </div>
            
            </form>

            


            <Link to="/">retornar a página inicial</Link>
            </div>
            <Footer></Footer>
        </div>
    );
}}

export default Login;