import React, { Component } from 'react';
import { fetchQuiz } from "../../actions";
import { connect } from 'react-redux';
import Grid from '@material-ui/core/Grid';
import Question from './Question';


class Quiz extends Component {

    constructor(props) {
        super(props)
    }

    render() {
        return (
            <div class ="flex-container">
                <h1>{this.props.quiz.name}</h1>
                {
                    this.props.quiz.questions.map((data, i) => (
                    <Question questionText={data.questionText} answers={data.answers} key={i} />
                ))
           
                }
                
            </div>
        );
    }

    componentDidMount() {
        this.props.fetchQuiz(this.props.match.params.quizId)
    }
}

function mapDispatchToProps(dispatch) {
    return {
        fetchQuiz: (id) => dispatch(fetchQuiz(id)),
    }
}

function mapStateToProps(state, ownProps) {
    return {
        quiz: state.quiz
    }
}


export default connect(mapStateToProps, mapDispatchToProps)(Quiz);