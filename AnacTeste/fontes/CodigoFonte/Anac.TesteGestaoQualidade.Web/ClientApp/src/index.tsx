import React from 'react';
import ReactDOM from 'react-dom';
import { App } from '@ux_components/all';
import routes from './routes';

ReactDOM.render(
    <React.StrictMode>
        <App authOnLoad routes={routes} />
    </React.StrictMode>,
    document.getElementById('root')
);
