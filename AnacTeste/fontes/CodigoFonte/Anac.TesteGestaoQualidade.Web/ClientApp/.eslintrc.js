module.exports = {
    env: {
        browser: true,
        es2021: true
    },
    extends: [
        'plugin:react/recommended',
        'airbnb',
        'plugin:prettier/recommended',
        'plugin:@typescript-eslint/recommended'
    ],
    parser: '@typescript-eslint/parser',
    parserOptions: {
        ecmaFeatures: {
            jsx: true
        },
        ecmaVersion: 12,
        sourceType: 'module'
    },
    plugins: ['react', '@typescript-eslint', 'prettier'],
    rules: {
        'import/no-unresolved': 'error',
        'react/jsx-filename-extension': 'off',
        'react/react-in-jsx-scope': 'off',
        'import/extensions': 'off',
        'react/jsx-props-no-spreading': 'off',
        'react/require-default-props': 'off',
        'no-use-before-define': 'off',
        '@typescript-eslint/explicit-module-boundary-types': 'off',
        'jsx-a11y/anchor-is-valid': 'off',
        'no-restricted-syntax': 'off',
        'no-new': 'off',
        'react/jsx-indent': 'off',
        'import/prefer-default-export': 'off',
        '@typescript-eslint/no-explicit-any': 'off',
        '@typescript-eslint/no-empty-interface': 'off',
        'react/jsx-one-expression-per-line': 'off',
        'prettier/prettier': 'off'
    },
    settings: {
        'import/resolver': {
            typescript: {}
        }
    }
};
