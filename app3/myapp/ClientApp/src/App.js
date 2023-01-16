import React, { useEffect, useState } from 'react';

const App = () => {

  const [playerarr,setplayerarr] = useState([]);

  useEffect(() => {
    fetch("api/player/GetPlayers")
    .then(response => {return response.json()})
    .then(responsejson => {
      console.log(responsejson)
      setplayerarr(responsejson)
    })
  },[]);



  return (
    <>
    <div className="container">
            <h1>Employees</h1>
            <div className="row">
                <div className="col-sm-12">
                    <table className="table table-striped">
                        <thead>
                            <tr>
                                <th>IdEmployee</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Address</th>
                                <th>Phone</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                playerarr.map((item) => (
                                    <tr key={item.id}>
                                        <td>{item.id}</td>
                                        <td>{item.name}</td>
                                        <td>{item.email}</td>
                                        <td>{item.sport}</td>
                                        <td>{item.phone}</td>
                                    </tr>
                                    
                                    ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </>)
}
export default App;