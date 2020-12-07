import React, { Component } from 'react';
import fetchQuizList from "../../actions";
import { connect } from 'react-redux';
import Grid from '@material-ui/core/Grid';
import QuizListElement from './QuizListElement';
import { createBrowserHistory } from 'history';
export const history = createBrowserHistory({ forceRefresh: true })
class QuizList extends Component {

    constructor(props) {
        super(props)
    }

    render() {
       
        return (
            <Grid container direction={'row'}  spacing={2}>
                {
                    this.props.quizList.map((data, i) => (
                        <button onClick={() => this.selectQuiz(data.quizId)}>  <Grid item component={QuizListElement} onClick={() => this.selectQuiz(data.quizId)} value={data} key={i} w={2} /></button>

                ))
                }
                </Grid>
                );
    }
    selectQuiz(quizId) {
    history.push("/quiz/" + quizId)
}

    componentDidMount() {
        this.props.fetchQuizList(this.props.match.params.topicId);
    }
}


function mapDispatchToProps(dispatch) {
    return {
        fetchQuizList: (id) => dispatch(fetchQuizList(id)),
    }
}

function mapStateToProps(state, ownProps){
    return {
        quizList: state.quizList
    }
}


export default connect(mapStateToProps, mapDispatchToProps)(QuizList);