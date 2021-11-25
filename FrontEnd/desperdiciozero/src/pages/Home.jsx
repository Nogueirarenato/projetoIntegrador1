import React from 'react';
import Cabecalho from "../components/HeaderHome"
import 'bootstrap/dist/css/bootstrap.min.css'
import Rodape from '../components/Footer';
import "../styles/Styles.css"
import IMG1 from "../images/1.png"
import IMG2 from "../images/2.png"
import IMG3 from "../images/3.png"
import Carousel from 'react-bootstrap/Carousel';
import Button from 'react-bootstrap/Carousel';


const Home = () => {
  return (
    <div >
      <Cabecalho></Cabecalho>
      <div className="bodyReact">

        <div style={{ maxWidth: "60vw", marginLeft: "20vw", marginTop: "3vh" }}>
          <Carousel >
            <Carousel.Item>
              <img
                className="d-block w-100"
                src={IMG1}
                alt="First slide"
              />
              <Carousel.Caption>
                
                
              </Carousel.Caption>
            </Carousel.Item>
            <Carousel.Item>
              <img
                className="d-block w-100"
                src={IMG2}
                alt="Second slide"
              />

              <Carousel.Caption>
             
              </Carousel.Caption>
            </Carousel.Item>
            <Carousel.Item>
              <img
                className="d-block w-100"
                src={IMG3}
                alt="Third slide"
              />

              <Carousel.Caption>
               
              </Carousel.Caption>
            </Carousel.Item>
          </Carousel>
        </div>
        
        

      </div>


      <Rodape></Rodape>
    </div>
  );
}

export default Home;