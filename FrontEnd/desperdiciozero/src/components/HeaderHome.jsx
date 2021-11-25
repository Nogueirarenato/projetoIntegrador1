import React from 'react';
import "../styles/Styles.css"
import { Link } from 'react-router-dom';

const HeaderHome = () => {
    return (
        <div className="header"> <div className="nav01">
          <a className="link1" href=".\"><h1>Projeto Desperdício Zero!</h1></a>
          <a className="link2" href=".\Login"><h2>Login</h2></a>
          <a className="link2" href=".\EfetuarCadastro"><h2>Efetuar Cadastro</h2></a>
          </div> 
            
        </div>
    );
}

export default HeaderHome;