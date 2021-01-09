import React, { useEffect, useState } from "react";
// @material-ui/core components
import { makeStyles } from "@material-ui/core/styles";
import InputLabel from "@material-ui/core/InputLabel";
// core components
import GridItem from "components/Grid/GridItem.js";
import GridContainer from "components/Grid/GridContainer.js";
import CustomInput from "components/CustomInput/CustomInput.js";
import Button from "components/CustomButtons/Button.js";
import Card from "components/Card/Card.js";
import CardHeader from "components/Card/CardHeader.js";
import CardAvatar from "components/Card/CardAvatar.js";
import CardBody from "components/Card/CardBody.js";
import CardFooter from "components/Card/CardFooter.js";

import avatar from "assets/img/faces/marc.jpg";

import CatalogosDAO from "DAO/CatalogosDAO.js"
const styles = {
  cardCategoryWhite: {
    color: "rgba(255,255,255,.62)",
    margin: "0",
    fontSize: "14px",
    marginTop: "0",
    marginBottom: "0"
  },
  cardTitleWhite: {
    color: "#FFFFFF",
    marginTop: "0px",
    minHeight: "auto",
    fontWeight: "300",
    fontFamily: "'Roboto', 'Helvetica', 'Arial', sans-serif",
    marginBottom: "3px",
    textDecoration: "none"
  }
};

const useStyles = makeStyles(styles);

export default function CadastroRevendedorasView() {

  const [catalogos, setCatalogos] = useState([])
  const classes = useStyles();

  async function getCatalogos() {
    setCatalogos(await new CatalogosDAO().getCatalogos())
  }

  useEffect(() => {
    getCatalogos()

  }, [])



  return (
    <div>
      <GridContainer>
        <GridItem xs={12} sm={12} md={12}>
          <Card>
            <CardHeader color="primary">
              <h4 className={classes.cardTitleWhite}>Cadastrar revendedora</h4>
            </CardHeader>
            <CardBody>
              <GridContainer>
                {/* <GridItem xs={12} sm={12} md={5}>
                  <CustomInput
                    labelText="Company (disabled)"
                    id="company-disabled"
                    formControlProps={{
                      fullWidth: true
                    }}
                    inputProps={{
                      disabled: true
                    }}
                  />
                </GridItem>
                */}
                <GridItem xs={12} sm={12} md={12}>
                  <CustomInput
                    labelText="Nome"
                    id="nome"
                    formControlProps={{
                      fullWidth: true
                    }}
                  />
                </GridItem>
              </GridContainer>
              <GridContainer>

                <GridItem>
                  <h5>Catalogos</h5>
                </GridItem>
              </GridContainer>

              {catalogos.map((value, index) => {
                return (<GridContainer>
                  <GridItem >{value.cat_nome}
                    <CustomInput
                      id="company-disabled"
                      formControlProps={{
                      }} />
                  </GridItem>
                </GridContainer>)
              })}
            </CardBody>

            <CardFooter>
              <Button color="primary">Update Profile</Button>
            </CardFooter>

          </Card>
        </GridItem>
      </GridContainer>
    </div>
  );
}
