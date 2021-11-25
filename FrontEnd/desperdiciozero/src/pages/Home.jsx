import React from 'react';
import { Link } from 'react-router-dom';
import Header from "../components/Header"
import Footer from '../components/Footer';
import "../styles/Styles.css"
const Home = () =>{
  return (
    <div>
      <Header></Header>
      <div className="bodyReact">
        <h1>DesperdicioZero</h1>

        <Link to="/Login">Login</Link>
        <Link to="/EfetuarCadastro">EfetuarCadastro</Link>

      </div>


      <Footer></Footer>
    </div>
  );
}

export default Home;