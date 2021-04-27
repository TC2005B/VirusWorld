const express = require("express")
const cors = require("cors")
const database = require("./Database");
const port = 5001

app = express()
app.use(express.urlencoded({ extended: true }));
app.use(cors())
app.use(express.json())

app.get('/', (req, res) => {
    console.log("get request")
    res.json("ASDA")
})

app.post('/add', (request, response) => {
    let Usuario = {
        "usuario": request.body.Usuario,
        "edad": request.body.Edad,
        "nivelesvisitados": request.body.NV,
        "nivelescompletados": request.body.NC,
        "visitascpu": request.body.CPU,
        "visitasram": request.body.RAM,
        "visitashdd": request.body.HDD
    };
    //console.log(Usuario)
    console.log("entro al endpoint de add")
    console.log(request.body)
    database.addUser(Usuario.usuario, Usuario.edad, Usuario.nivelesvisitados, Usuario.nivelescompletados, Usuario.visitascpu, Usuario.visitasram, Usuario.visitashdd);
    response.json({ "message": "Added data correctly" })
})

app.post("/edit", function(request, response) {
    let usuario = request.body.Usuario
    let nivelesvisitados = request.body.NV
    let nivelescompletados = request.body.NC
    let visitascpu = request.body.CPU
    let visitasram = request.body.RAM
    let visitashdd = request.body.HDD
    database.editUser(usuario, nivelesvisitados, nivelescompletados, visitascpu, visitasram, visitashdd)

    console.log("entro al endpoint de edit")
    response.json({ "message": "updated data correctly" })

    console.log(request.body)
})

app.listen(port, () => {
    console.log(`App listening at http://localhost:${port}`);
})