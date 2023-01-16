import React, { Component, useEffect, useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

const App = () => {

  const [students, setstudents] = useState([]);

  useEffect(() => {
    fetch("api/student/GetStudents")
      .then(response => { return response.json() })
      .then(responsejson => {
        console.log(responsejson)
        setstudents(responsejson)
      })
  }, []);


  return <div>
    <table >
      <thead>
      <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Email</th>
      </tr>
      </thead>
      <tbody>
      {students.map((item) => {
        return <tr key={item.id}>
            <td>{item.id}</td>
            <td>{item.name}</td>
            <td>{item.email}</td>
          </tr>
        })}
      </tbody>
    </table>
  </div>
}

export default App;