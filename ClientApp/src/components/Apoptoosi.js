import React, { Component } from 'react';
import { ApoptoosiForm } from './ApoptoosiForm';

export class Apoptoosi extends Component {
  displayName = Apoptoosi.name

  constructor(props) {
    super(props);
    this.state = { registrations: [], loading: true };
  } 
  componentDidMount(){

      fetch('api/registrationData/registrations')
      .then(response => response.json())
      .then(data => {
        this.setState({ registrations: data, loading: false });
      })
      .catch(error => this.setState({loading: false}))
    }

  static renderregistrationsTable(registrations) {
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
          {registrations.map(registration =>
            <tr key='ebin123'>
              <td>{registration.name}</td>
              <td>{registration.seatingGroup}</td>
              <td>{registration.alcohol}</td>
              <td>{registration.text}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Apoptoosi.renderregistrationsTable(this.state.registrations);

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
