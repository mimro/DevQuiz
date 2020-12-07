import React, { Component } from 'react';
import { connect } from 'react-redux';
import Paper from '@material-ui/core/Paper';
import './styles/question.css'
import Box from '@material-ui/core/Box';
import RadioGroup from '@material-ui/core/RadioGroup';
import Answer from './Answer';



class Question extends Component {

    constructor(props) {
        super(props)
    }

    render() {
        return (
            <Box component={Paper} elevation={4} width={1 / 4} height={1 / 5} m={3} >
                
                    <h3>  {this.props.questionText}</h3>
                <RadioGroup aria-label="answer" name="answer" value={0}>
                        {
                        this.props.answers.map((data, i) => (
                 
                            <Answer key={i} indexvalue={i} value={data.answerText} />
                           
                            ))
                        }
                </RadioGroup>
               

            </Box>
        );
    }
}

export default (Question)