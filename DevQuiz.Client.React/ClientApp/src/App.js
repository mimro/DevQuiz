import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';


import './custom.css'
import QuizList from './components/QuizList/QuizList';
import QuizTopicList from './components/QuizList/QuizTopicList';
import Quiz from './components/Quiz/Quiz';



export default class App extends Component {
  static displayName = App.name;


    render() {
      return (
      <Layout>
        <Route exact path='/' component={QuizTopicList} />
              <Route path='/quizList/:topicId' component={QuizList} />
              <Route path='/quiz/:quizId' component={Quiz} />

              </Layout>
    );
  }
}
