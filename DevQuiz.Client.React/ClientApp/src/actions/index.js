import axios from 'axios';
export function selectQuiz(id: string) {
    return {
        type: "SELECT_QUIZ",
        id
    }
}

export const fetchQuizListSuccess = quizList => ({
    type: 'FETCH_QUIZ_LIST_SUCCESS',
    payload: { quizList }
})

export default function fetchQuizList(id){
    return async dispatch => {
        try {
            await axios.get('https://localhost:44326/api/quizzes', { params: { topicId: id } }).then(response =>               
            dispatch(fetchQuizListSuccess(response.data))
            );
        }
        catch (e) {
            console.log(e);
        }
    }
}

export function selectAnswer(questionId: string,answer: int) {
    return {
        type: "SELECT_ANSWER",
        questionId,
        answer
    }
}

export const fetchQuizSuccess = quiz => ({
    type: 'FETCH_QUIZ_SUCCESS',
    payload: { quiz }
})

export function fetchQuiz(id) {
    return async dispatch => {
        try {
            await axios.get('https://localhost:44326/api/quizzes/'+ id).then(response =>
                dispatch(fetchQuizSuccess(response.data))
            );
        }
        catch (e) {
            console.log(e);
        }
    }
}