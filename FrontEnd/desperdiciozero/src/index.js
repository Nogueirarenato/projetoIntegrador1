import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import { Routes, Route, BrowserRouter as Router} from "react-router-dom"
import Home from "./pages/Home";
import Login from "./pages/Login";
import Administrador from "./pages/Administrador";
import FazerPedido from './pages/FazerPedido';
import Vendedor from './pages/Vendedor';
import EfetuarCadastro from './pages/EfetuarCadastro';
import CadastrarProduto from './pages/CadastrarProduto';



const routing = ( 


           
           
<Router>
<Routes> 
<Route exact path="/" element={<Home/>} />
<Route exact path="/Login" element={<Login/>} />
<Route exact path="/Administrador" element={<Administrador/>} />
<Route exact path="/FazerPedido" element={<FazerPedido/>} />
<Route exact path="/Vendedor" element={<Vendedor/>} />
<Route exact path="/EfetuarCadastro" element={<EfetuarCadastro/>} />
<Route exact path="/CadastrarProduto" element={<CadastrarProduto/>} />
</Routes> 
</Router>

)

ReactDOM.render(routing, document.getElementById('root') 
  
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
