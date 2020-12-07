import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

import { createMuiTheme } from '@material-ui/core/styles';
import { ThemeProvider } from '@material-ui/styles';

//Redux store imports
import { Provider } from "react-redux";
import configureStore from "./store/configureStore";
import rootReducer from "./reducers";
import fetchQuizList from "./actions";

let store = configureStore(rootReducer);
//store.dispatch(fetchQuizList());
const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');
const darkTheme = createMuiTheme({
    palette: {
        type: 'dark',
    },
});
ReactDOM.render(
    
    <BrowserRouter basename={baseUrl}>
        <Provider store={store}>
            <ThemeProvider theme={darkTheme}>
                <App />
            </ThemeProvider>
        </Provider>
  </BrowserRouter>,     
  rootElement);

registerServiceWorker();

