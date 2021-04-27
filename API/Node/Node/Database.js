const { json } = require("express");
const fs = require("fs");
let resultado = [];

var mysql = require('mysql')
var connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'Q123456',
    database: 'api'
})

connection.connect();


function addUser(usuario, edad, nivelesvisitados, nivelescompletados, visitascpu, visitasram, visitashdd) {
    connection.query('INSERT INTO usuarios SET ?', {
        Usuario: usuario,
        Edad: edad,
        NivelesVisitados: nivelesvisitados,
        NivelesCompletados: nivelescompletados,
        VisitasCPU: visitascpu,
        VisitasRAM: visitasram,
        VisitasHDD: visitashdd
    }, function(err, rows, fields) {
        if (err) throw err
    })
    console.log("entro a adduser")
}



function editUser(usuario, nivelesvisitados, nivelescompletados, visitascpu, visitasram, visitashdd) {
    connection.query('UPDATE usuarios SET NivelesVisitados = ?, NivelesCompletados = ?, VisitasCPU = ?, VisitasRAM = ?, VisitasHDD = ? WHERE Usuario = ?', [nivelesvisitados, nivelescompletados, visitascpu, visitasram, visitashdd, usuario], function(err, results, fields) {
        if (err) {
            throw err
        } else {
            console.log("Se Modifico");
        }
    })
}

module.exports = { addUser, editUser };