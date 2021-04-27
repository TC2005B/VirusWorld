const express = require("express");
const server = express();
const database = require("./Database");
const port = 3000;
server.set("view-engine", "ejs");



// server.post("/add", function(request, response) {
//     let Usuario = {
//         "usuario": request.body.Usuario,
//         "edad": request.body.Edad,
//         "nivelesvisitados": request.body.NV,
//         "nivelescompletados": request.body.NC,
//         "visitascpu": request.body.CPU,
//         "visitasram": request.body.RAM,
//         "visitashdd": request.body.HDD
//     };
//     console.log("entro al endpoint de add")
//     database.addUser(Usuario.usuario, Usuario.edad, Usuario.nivelesvisitados, Usuario.nivelescompletados, Usuario.visitascpu, Usuario.visitasram, Usuario.visitashdd);
// });





// server.post("/edit", function(request, response) {
//     let usuario = request.body.Usuario;
//     let nivelesvisitados = request.body.NV;
//     let nivelescompletados = request.body.NC;
//     let visitascpu = request.body.CPU;
//     let visitasram = request.body.RAM;
//     let visitashdd = request.body.HDD;
//     database.editUser(usuario, nivelesvisitados, nivelescompletados, visitascpu, visitasram, visitashdd);
// });


server.listen(port, function() {
    console.log("Running at ", port);
});