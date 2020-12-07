import React, { Component } from 'react';
import FormControl from '@material-ui/core/FormControl';
import Radio from '@material-ui/core/Radio';

import FormControlLabel from '@material-ui/core/FormControlLabel';


class Answer extends Component {

    constructor(props) {
        super(props)
    }

    render() {
        return (
            <FormControlLabel value={this.props.indexvalue} control={<Radio />} label={this.props.value} />
        );
    }
}

export default (Answer)