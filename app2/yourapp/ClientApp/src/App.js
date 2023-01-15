import React, { Component, useEffect, useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

const App = () => {
  const [emparr, setemparr] = useState([]);

  useEffect(() => {
    fetch("api/employee/GetEmployees")
    .then(Response => {return Response.json()})
    .then(ResponseJson => {
      console.log(ResponseJson)
      setemparr(ResponseJson)
    })
  },[]);

  return <div> 
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>Email</th>
          <th>Address</th>
          <th>Phone</th>
        </tr>
      </thead>
      <tbody>
        {emparr.map((item)  => {
          return <tr key={item.id}>
            <td>{item.id}</td>
            <td>{item.name}</td>
            <td>{item.email}</td>
            <td>{item.address}</td>
            <td>{item.phone}</td>
          </tr>
        })}
      </tbody>
    </table>

  </div>
}

export default App;

