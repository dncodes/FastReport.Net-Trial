import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarToggler } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
                    <Container>
                        <span className="intro" tag={Link} to="/">FastReport.Core.React</span>
                        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                        <img className="fr-logo" alt="FR logo" src="./logo.png" />
                        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                            <ul className="navbar-nav flex-grow">
                            </ul>
                        </Collapse>
                    </Container>
                </Navbar>
            </header>
        )
    }
}
