from connexion.apps.flask_app import FlaskJSONEncoder

from openapi_server.models.base_model import Model


class JSONEncoder(FlaskJSONEncoder):
    include_nulls = False

    def default(self, o):
        if isinstance(o, Model):
            dikt = {}
            for attr in o.openapi_types:
                value = getattr(o, attr)
                if value is None and not self.include_nulls:
                    continue
                attr = o.attribute_map[attr]
                dikt[attr] = value
            return dikt
        elif isinstance(o, bytes):
            return str(o, encoding='utf-8')

        return FlaskJSONEncoder.default(self, o)
