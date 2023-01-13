import { useAppConfig, Page } from '@ux_components/all';
import React, { useEffect } from 'react';

const Home = () => {
    const { applicationName } = useAppConfig();

    return (
        <Page title="Página Inicial">
            <p>
                Bem vindo ao sistema <strong>{applicationName}</strong>
            </p>
        </Page>
    );
};

export default Home;
