import React, { Component } from 'react';
import Paper from '@material-ui/core/Paper';

export default class QuizListElement extends Component {

    constructor(props) {
        super(props)
    }

    render() {
        return (
            <Paper elevation={2} m={3}>
                <h3>
                    {this.props.value.name}
                    {this.props.value.quizLevel}

                    </h3>
                </Paper>
        );
    }
}