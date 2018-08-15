import React, { Component } from 'react';
import { ApoptoosiForm } from './ApoptoosiForm';

export class Apoptoosi extends Component {
  displayName = Apoptoosi.name

  constructor(props) {
    super(props);
    this.state = { registerations: [], loading: true };
  }
  componentDidMount(){
    fetch('api/RegisterirationData/Registerirations')
    .then(response => response.json())
      .then(data => {
        this.setState({ registerations: data, loading: false });
      });
  }

  static renderRegisterationsTable(registerations) {
    return (
      <table className='table'>
        <thead>
          <tr>
            <th>Name</th>
            <th>Group</th>
            <th>Alcohol</th>
            <th>Helloings</th>
          </tr>
        </thead>
        <tbody>
          {registerations.map(registeration =>
            <tr key='ebin123'>
              <td>{registeration.name}</td>
              <td>{registeration.seatingGroup}</td>
              <td>{registeration.alcohol}</td>
              <td>{registeration.text}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Apoptoosi.renderRegisterationsTable(this.state.registerations);

    return (
      <div>
        <h1>Apoptoosi</h1>
        <p>This component demonstrates fetching data from the server.</p>
            {contents}
            <ApoptoosiForm />
     </div>
    );
  }
}
