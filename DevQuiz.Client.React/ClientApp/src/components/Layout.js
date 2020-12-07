import React, { Component } from 'react';
import Container from '@material-ui/core/Container';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
           
         <Container>
          {this.props.children}
         </Container>
      </div>
    );
  }
}
