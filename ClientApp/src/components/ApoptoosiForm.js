import React, { Component } from 'react';

export class ApoptoosiForm extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: '',
            seatingGroup: '',
            alcohol: '',
            text: '',
        };

        this.handleChange = this.handleChange.bind(this);
        this.createRegistration = this.handleSubmit.bind(this);
    }

    handleChange(event) {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;
        this.setState({ [name]: value });
    }

    handleSubmit(event) {

        fetch('api/RegisterirationData/Createregisteration', {
            headers: {
                'Connection': 'keep-alive',
                'Content-Type': 'application/json'

            },
            method: 'POST',
            body: JSON.stringify(
                this.state,
            )

        });
        event.preventDefault();
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit.bind(this)}>
                
                <label>
                    Apoptoosi form
                </label>
                <div class="form-group">
                    <input  class="form-control" type="text" name="name" value={this.state.name} onChange={this.handleChange}  />
                </div>
                <div class="form-group">
                    <input class="form-control" type="text" name="seatingGroup" value={this.state.seatingGroup} onChange={this.handleChange}  />
                </div>
                <div class="form-group">
                    <input class="form-check-input" type="checkbox" name="alcohol" value={this.state.alcohol} onChange={this.handleChange}  />
                </div>
                <div class="form-group">
                    <input class="form-control"  type="text" name="text" value={this.state.helloings} onChange={this.handleChange} />
                </div>
                <button class="btn btn-primary" type="submit" >Submit</button>

            </form>
        );
    }
}