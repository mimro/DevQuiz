const initState = {
    quizId: '',
    name: '',
    questions: [],
    quizTopic:0,
    quizLevel: 0,

}

const quizReducer = (state = initState, action) => {

    switch (action.type) {
        case 'FETCH_QUIZ_SUCCESS':
            return action.payload.quiz
        default:
            return state
    }
}

export default quizReducer