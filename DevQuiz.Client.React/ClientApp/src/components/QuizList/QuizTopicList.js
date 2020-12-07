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


        {
        return (
            <div>
                Select topic
                { history.push("/quizList/1")}
            </div>
        );
    }
    }}

function mapStateToProps(state, ownProps) {
    return {
        quizList: state.quizList
    }
}


export default connect(mapStateToProps)(QuizList);