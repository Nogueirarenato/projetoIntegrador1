import React from 'react';
import "../styles/Styles.css"
import Logo from "../images/univesp.png";
import Git from "../images/git.png";


const Footer = () => {
    return (
        <div className="footer">
            <img src={Logo} alt="Logo da Univesp" className="img-1" />
            <p className="footer-l">O <span className="b">Projeto Desperdício Zero!</span> é uma iniciativa dos alunos do Eixo de Computação da Univesp polo Osasco como parte da Disciplina Projeto Integrador I ministrada no segundo semestre de 2021.</p>
            <p className="footer-m">Visite nosso repositorio no Github.  </p><a href="https://github.com/Nogueirarenato/projetoIntegrador1"><img className="img-2" src={Git}  alt="logo github"/></a>
            <p className="footer-n">UNIVESP 2021</p>
        
        </div>

    );
}

export default Footer;